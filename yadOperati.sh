installSoftware () {
    ansible-playbook ./ansiblePlaybook.yml -K
}

deleteSoftware () {
    ansible-playbook ./ansibleDelete.yml -K
}

ApacheON () {
    sudo systemctl start sshd
}

ApacheOff () {
    sudo systemctl stop sshd
}

MySQLON () {
    sudo systemctl start mysqld
}

MySQLOFF () {
    sudo systemctl stop mysqld
}

PortsDown () {
    sudo firewall-cmd --remove-port=80/tcp
    sudo firewall-cmd --remove-port=443/tcp
    sudo firewall-cmd --remove-port=22/tcp
    sudo firewall-cmd --remove-port=1433/tcp
    sudo firewall-cmd --runtime-to-permanent
}

PortsUP () {
    sudo firewall-cmd --add-port=80/tcp
    sudo firewall-cmd --add-port=443/tcp
    sudo firewall-cmd --add-port=22/tcp
    sudo firewall-cmd --add-port=1433/tcp
    sudo firewall-cmd --runtime-to-permanent
}

StaticIP () {

    yad --text="Esta opción funciona ejecutándola en el servidor a configurar, no funciona de forma remota"

    IP=$(yad --entry \
    --title="Establecer IP Estática" \
    --width=250 \
    --height=75 \
    --button=Siguiente:0 \
    --center \
    --text="Ingresa la IP Deseada")

        Netmask=$(yad --entry \
        --title="Establecer IP Estática" \
        --width=250 \
        --height=75 \
        --button=Siguiente:0 \
        --center \
        --text="Ingresa la Máscara Deseada")

        Gateway=$(yad --entry \
        --title="Establecer IP Estática" \
        --width=250 \
        --height=75 \
        --button=Siguiente:0 \
        --center \
        --text="Ingresa la IP del Router")
    
    
        DNS1=$(yad --entry \
        --title="Establecer IP Estática" \
        --width=250 \
        --height=75 \
        --button=Siguiente:0 \
        --center \
        --text="Ingresa el DNS Principal")
    
    
        DNS2=$(yad --entry \
        --title="Establecer IP Estática" \
        --width=250 \
        --height=75 \
        --button=Siguiente:0 \
        --center \
        --text="Ingresa el DNS Secundario")

    
        cmd=$(yad --title='Establecer IP Estática' \
        --center \
        --text-align=center \
        --width=350 \
        --button=Cancelar:0 \
        --button=Siguiente:1 \
        --text="¿Quieres establecer la siguiente configuración de red?\n \n \n  IP: $IP \n Máscara: $Netmask \n Gateway: $Gateway \n DNS1: $DNS1 \n DNS2: $DNS2")

        if [ $? -eq 1 ]
        then

        archivo=$(ls /etc/sysconfig/network-scripts/ | grep "ifcfg" | grep -v "ifcfg-lo" | cat)

        if [ -n "$( cat /etc/sysconfig/network-scripts/$archivo | sed -n '/IP/p')" ]
        then

        yad --text="El Servidor ya cuenta con una IP Estática Establecida"

        else
        
        sed -i 's/ONBOOT=no/ONBOOT=yes/' /etc/sysconfig/network-scripts/$archivo
        sed -i 's/dhcp/static/' /etc/sysconfig/network-scripts/$archivo
        echo IPADDR=$IP >> /etc/sysconfig/network-scripts/$archivo
        echo NETMASK=$Netmask >> /etc/sysconfig/network-scripts/$archivo
        echo GATEWAY=$Gateway >> /etc/sysconfig/network-scripts/$archivo
        echo DNS1=$DNS1 >> /etc/sysconfig/network-scripts/$archivo
        echo DNS2=$DNS2 >> /etc/sysconfig/network-scripts/$archivo
        fi
        fi
}

DynamicIP () {
    yad --text="¿Está seguro de que quiere establecer la IP Dinámica?"
    if [ $? -eq 0 ]
    then
    archivo=$(ls /etc/sysconfig/network-scripts/ | grep "ifcfg" | grep -v "ifcfg-lo" | cat)
    sed -i 's/static/dhcp/' /etc/sysconfig/network-scripts/$archivo
    sed -i '/IP/d' /etc/sysconfig/network-scripts/$archivo
    sed -i '/NETMASK/d' /etc/sysconfig/network-scripts/$archivo
    sed -i '/GATEWAY/d' /etc/sysconfig/network-scripts/$archivo
    sed -i '/DNS1/d' /etc/sysconfig/network-scripts/$archivo
    sed -i '/DNS2/d' /etc/sysconfig/network-scripts/$archivo
    fi
}


goodSystem () {

grep 'LOGIN ON' /var/log/secure

}
badSystem () {

grep 'FAILED LOGIN' /var/log/secure

}

Logs () {
    salidaYad=$(yad \
    --list \
    --text-align=center \
    --center \
    --width=325 \
    --height=325 \
    --button="gtk-ok:0" \
    --radiolist \
    --column 'Selección' \
    --column 'Item' \
    TRUE 'Log ins exitosos de MySQL' \
    FALSE 'Log ins fallidos de MySQL' )

    valorSalida=$?

    if [ $valorSalida -eq 0 ]
then
    case $salidaYad in
        **'Log ins exitosos de MySQL'**) goodMySQL ;;
        **'Log ins fallidos de MySQL'**) badMySQL ;;

    esac
else if [ $valorSalida -eq 252 ]
then
    echo "Te crees vivo? Cerrar la ventana no te hace más inteligente"
fi
fi
}


#YAD Principal
salidaYad=$(yad \
    --list \
    --text-align=center \
    --center \
    --width=325 \
    --height=325 \
    --button="gtk-ok:0" \
    --radiolist \
    --column 'Selección' \
    --column 'Item' \
    TRUE 'Instalación de Software' \
    FALSE 'Desinstalar Software'\
    FALSE 'Encender Apache' \
    FALSE 'Apagar Apache' \
    FALSE 'Encender MySQL' \
    FALSE 'Apagar MySQL' \
    FALSE 'Bajar Puertos' \
    FALSE 'Habilitar Puertos' \
    FALSE 'Establecer IP Estática' \
    FALSE 'Establecer IP Dinámica' \
    FALSE 'Ver intentos de Log in')



valorSalida=$?

#echo $cmd
#echo $valorSalida

if [ $valorSalida -eq 0 ]
then
    case $salidaYad in
        **'Instalación de Software'**) installSoftware ;;
        **'Desinstalar Software'**) deleteSoftware ;;
        **'Encender Apache'**) ApacheON ;;
        **'Apagar Apache'**) ApacheOff ;;
        **'Encender MySQL'**) MySQLON ;;
        **'Apagar MySQL'**) MySQLOFF ;;
        **'Bajar Puertos'**) PortsDown ;;
        **'Habilitar Puertos'**) PortsUP ;;
        **Estática**) StaticIP;;
        **Dinámica**) DynamicIP;;
        **'Log in'**) Logs;;

    esac
else if [ $valorSalida -eq 252 ]
then
    echo "Te crees vivo? Cerrar la ventana no te hace más inteligente"
fi
fi