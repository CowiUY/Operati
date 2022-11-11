use gabriel_moreira;

CREATE TABLE Usuario(
ID_Usuario int PRIMARY KEY,
Mail varchar(35) NOT NULL,
Nombre varchar(25) NOT NULL,
Contrasena varchar(30) NOT NULL);

CREATE TABLE Rol (
ID_Rol int PRIMARY KEY,
Nom_Rol varchar(25) NOT NULL);

CREATE TABLE Publicidad (
ID_Publicidad int PRIMARY KEY,
Marca varchar(35) NOT NULL);

CREATE TABLE Paises (
ID_Pais int PRIMARY KEY,
Pais varchar(40) NOT NULL);

CREATE TABLE Nacionalidades (
ID_Nacionalidad int PRIMARY KEY,
Nacionalidad varchar (30) NOT NULL);

CREATE TABLE Deporte (
ID_Deporte int PRIMARY KEY,
Nom_Deporte varchar(20) NOT NULL);

CREATE TABLE Evento_Deportivo (
ID_Evento int PRIMARY KEY,
Nom_Evento varchar (40) NOT NULL,
Individual boolean NOT NULL,
Cant_Participantes int NOT NULL);

CREATE TABLE Categorias (
ID_Categoria int PRIMARY KEY,
Categoria varchar(15) NOT NULL);

CREATE TABLE Participante (
ID_Participante int PRIMARY KEY );

CREATE TABLE Equipo (
ID_Participante int PRIMARY KEY,
Nom_Equipo varchar(35) NOT NULL,
FOREIGN KEY (ID_Participante) references Participante(ID_Participante));

CREATE TABLE Jugador (
ID_Participante int PRIMARY KEY,
Nom_Jugador varchar(25) NOT NULL,
Ape_Jugador varchar(25) NOT NULL,
FOREIGN KEY (ID_Participante) references Participante(ID_Participante));


CREATE TABLE Resultado (
ID_Resultado int PRIMARY KEY,
ID_Participante int NOT NULL,
FOREIGN KEY (ID_Participante) references Participante(ID_Participante));

CREATE TABLE Resultado_Partido (
ID_Resultado int PRIMARY KEY,
P_Local int NOT NULL,
P_Visitante int NOT NULL,
FOREIGN KEY (ID_Resultado) references Resultado(ID_Resultado));

CREATE TABLE Resultado_Carrera (
ID_Resultado int PRIMARY KEY,
Posicion int NOT NULL,
FOREIGN KEY (ID_Resultado) references Resultado(ID_Resultado));

CREATE TABLE Resultado_Sets (
ID_Resultado int PRIMARY KEY,
Sets int NOT NULL,
Puntos_Set int NOT NULL,
FOREIGN KEY (ID_Resultado) references Resultado(ID_Resultado));

CREATE TABLE Notificacion (
ID_Notificacion int PRIMARY KEY,
ID_Resultado int NOT NULL,
Minuto int NOT NULL,
FOREIGN KEY (ID_Resultado) references Resultado(ID_Resultado));

CREATE TABLE Cambio (
ID_Notificacion int PRIMARY KEY,
Sale_Entra int(1) NOT NULL,
FOREIGN KEY (ID_Notificacion) references Notificacion(ID_Notificacion),
CONSTRAINT Ch_SaleEntra CHECK(Sale_Entra='1' OR Sale_Entra='2'));

CREATE TABLE Amonestacion (
ID_Notificacion int PRIMARY KEY,
Sancion varchar(40) NOT NULL,
FOREIGN KEY (ID_Notificacion) references Notificacion(ID_Notificacion));

CREATE TABLE Punto (
ID_Notificacion int PRIMARY KEY,
Cant_Puntos int NOT NULL,
FOREIGN KEY (ID_Notificacion) references Notificacion(ID_Notificacion));

CREATE TABLE Encuentro (
ID_Encuentro int PRIMARY KEY,
Hora varchar(8) NOT NULL,
Fecha DATE );

CREATE TABLE Lugares (
ID_Lugar int PRIMARY KEY,
Lugares varchar (40) NOT NULL);

CREATE TABLE Lugares_Encuentro (
ID_Encuentro int PRIMARY KEY,
ID_Lugar int NOT NULL,
FOREIGN KEY (ID_Encuentro) references Encuentro(ID_Encuentro),
FOREIGN KEY (ID_Lugar) references Lugares(ID_Lugar));

CREATE TABLE Jugador_Equipo (
ID_Participante int PRIMARY KEY, /*Jugador*/
ID_Equipo int, /*Equipor*/
FOREIGN KEY (ID_Participante) references Participante(ID_Participante), /*Jugador*/
FOREIGN KEY (ID_Equipo) references Participante(ID_Participante)); /*Equipor*/

CREATE TABLE Nacionalidades_Jugador (
ID_Participante int PRIMARY KEY,
ID_Nacionalidad int NOT NULL,
FOREIGN KEY (ID_Participante) references Participante(ID_Participante),
FOREIGN KEY (ID_Nacionalidad) references Nacionalidades(ID_Nacionalidad));

CREATE TABLE Pais_Equipo (
ID_Participante int PRIMARY KEY,
ID_Pais int NOT NULL,
FOREIGN KEY (ID_Participante) references Participante(ID_Participante),
FOREIGN KEY (ID_Pais) references Paises(ID_Pais));

CREATE TABLE Categorias_Evento (
ID_Evento int PRIMARY KEY,
ID_Categoria int NOT NULL,
FOREIGN KEY (ID_Evento) references Evento_Deportivo(ID_Evento),
FOREIGN KEY (ID_Categoria) references Categorias(ID_Categoria));

CREATE TABLE Deporte_Evento (
ID_Deporte int PRIMARY KEY,
ID_Evento int NOT NULL,
Jugando boolean NOT NULL,
FOREIGN KEY (ID_Deporte) references Deporte(ID_Deporte),
FOREIGN KEY (ID_Evento) references Evento_Deportivo(ID_Evento));

CREATE TABLE Publicidad_Usuario (
ID_Publicidad int PRIMARY KEY,
ID_Usuario int NOT NULL,
FOREIGN KEY (ID_Usuario) references Usuario(ID_Usuario),
FOREIGN KEY (ID_Publicidad) references Publicidad(ID_Publicidad));

CREATE TABLE Participantes_Encuentro (
ID_Participante int PRIMARY KEY,
ID_Encuentro int NOT NULL,
Nom_Equipo varchar(35),
FOREIGN KEY (ID_Encuentro) references Encuentro(ID_Encuentro),
FOREIGN KEY (ID_Participante) references Participante(ID_Participante));

CREATE TABLE Resultado_Evento (
ID_Resultado int PRIMARY KEY,
ID_Evento int NOT NULL,
FOREIGN KEY (ID_Evento) references Evento_Deportivo(ID_Evento),
FOREIGN KEY (ID_Resultado) references Resultado(ID_Resultado));

CREATE TABLE Notificaciones_Usuario (
ID_Notificacion int PRIMARY KEY,
ID_Usuario int NOT NULL,
FOREIGN KEY (ID_Notificacion) references Notificacion(ID_Notificacion),
FOREIGN KEY (ID_Usuario) references Usuario(ID_Usuario));

CREATE TABLE Usuarios_Favoritos (
ID_Participante int PRIMARY KEY,
ID_Usuario int NOT NULL,
Recibe_Not boolean NOT NULL,
FOREIGN KEY (ID_Participante) references Participante(ID_Participante),
FOREIGN KEY (ID_Usuario) references Usuario(ID_Usuario));

CREATE TABLE Participantes_Evento (
ID_Evento int PRIMARY KEY,
ID_Participante int NOT NULL,
FOREIGN KEY (ID_Evento) references Evento_Deportivo(ID_Evento),
FOREIGN KEY (ID_Participante) references Participante(ID_Participante));

CREATE TABLE Resultado_Participante (
ID_Resultado int PRIMARY KEY,
ID_Participante int NOT NULL,
FOREIGN KEY (ID_Resultado) references Resultado(ID_Resultado),
FOREIGN KEY (ID_Participante) references Participante(ID_Participante));

CREATE TABLE Notificacion_Resultado (
ID_Notificacion int PRIMARY KEY,
ID_Resultado int NOT NULL,
FOREIGN KEY (ID_Resultado) references Resultado(ID_Resultado),
FOREIGN KEY (ID_Notificacion) references Notificacion(ID_Notificacion));