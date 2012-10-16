CREATE TABLE AUTHORITY 
    ( 
     Id_Authority INT(1)  NOT NULL , 
     Name_Of_Authority CHAR(10)  NOT NULL 
    ) 
;



ALTER TABLE AUTHORITY 
    ADD CONSTRAINT AUTHORITY_PK PRIMARY KEY ( Id_Authority ) ;


CREATE TABLE KIND_OF_RESOURCES 
    ( 
     Id_Kind INT(5)  NOT NULL , 
     Name CHAR(10)  NOT NULL 
    ) 
;



ALTER TABLE KIND_OF_RESOURCES 
    ADD CONSTRAINT Rodzaje_Zasoby_PK PRIMARY KEY ( Id_Kind ) ;


CREATE TABLE LIBRARY 
    ( 
     Id_Library INT(2)  NOT NULL , 
     Street CHAR(15)  NOT NULL , 
     Nr_House CHAR(4)  NOT NULL , 
     Nr_Local INT(4)  NOT NULL , 
     Manager_Name CHAR(15)  NOT NULL , 
     Manager_Surname CHAR(20)  NOT NULL 
    ) 
;



ALTER TABLE LIBRARY 
    ADD CONSTRAINT LIBRARY_PK PRIMARY KEY ( Id_Library ) ;


CREATE TABLE RESOURCES 
    ( 
     Id_Resources INT(5)  NOT NULL , 
     Id_Kind INT(5)  NOT NULL , 
     Title CHAR(50)  NOT NULL , 
     Author_Name CHAR(15)  NOT NULL , 
     Author_Surname CHAR(30)  NOT NULL , 
     Is_Available CHAR(1)  NOT NULL , 
     Is_Reserve CHAR(1)  NOT NULL 
    ) 
;



ALTER TABLE RESOURCES 
    ADD CONSTRAINT ZASOBY_PK PRIMARY KEY ( Id_Resources ) ;


CREATE TABLE RESOURCES_LIBRARY 
    ( 
     Id_Resources INT(5)  NOT NULL , 
     Id_Library INT(2)  NOT NULL 
    ) 
;



ALTER TABLE RESOURCES_LIBRARY 
    ADD CONSTRAINT RESOURCES_LIBRARY_PK PRIMARY KEY ( Id_Resources, Id_Library ) ;


CREATE TABLE RESOURCES_USERS 
    ( 
     Id_Resources INT(5)  NOT NULL , 
     Id_User INT(6)  NOT NULL 
    ) 
;



ALTER TABLE RESOURCES_USERS 
    ADD CONSTRAINT RESOURCES_USERS_PK PRIMARY KEY ( Id_Resources, Id_User ) ;


CREATE TABLE USERS 
    ( 
     Id_User INT(6)  NOT NULL , 
     Id_Authority INT(1)  NOT NULL , 
     User_Name CHAR(15)  NOT NULL , 
     User_Surname CHAR(20)  NOT NULL , 
     Pesel INT(11)  NOT NULL , 
     Limitk INT(1)  NOT NULL , 
     Amount_Of_Borrows INT(1)  NOT NULL , 
     Login CHAR(15)  NOT NULL , 
     Password CHAR(10)  NOT NULL 
    ) 
;



ALTER TABLE USERS 
    ADD CONSTRAINT USERS_PK PRIMARY KEY ( Id_User ) ;



ALTER TABLE RESOURCES_LIBRARY 
    ADD CONSTRAINT RESOURCES_LIBRARY_LIBRARY_FK FOREIGN KEY 
    ( 
     Id_Library
    ) 
    REFERENCES LIBRARY 
    ( 
     Id_Library
    ) 
;


ALTER TABLE RESOURCES_LIBRARY 
    ADD CONSTRAINT RESOURCES_LIBRARY_RESOURCES_FK FOREIGN KEY 
    ( 
     Id_Resources
    ) 
    REFERENCES RESOURCES 
    ( 
     Id_Resources
    ) 
;


ALTER TABLE RESOURCES_USERS 
    ADD CONSTRAINT RESOURCES_USERS_RESOURCES_FK FOREIGN KEY 
    ( 
     Id_Resources
    ) 
    REFERENCES RESOURCES 
    ( 
     Id_Resources
    ) 
;


ALTER TABLE RESOURCES_USERS 
    ADD CONSTRAINT RESOURCES_USERS_USERS_FK FOREIGN KEY 
    ( 
     Id_User
    ) 
    REFERENCES USERS 
    ( 
     Id_User
    ) 
;


ALTER TABLE RESOURCES 
    ADD CONSTRAINT RESOURCES_KIND_OF_RESOURCES_FK FOREIGN KEY 
    ( 
     Id_Kind
    ) 
    REFERENCES KIND_OF_RESOURCES 
    ( 
     Id_Kind
    ) 
;


ALTER TABLE USERS 
    ADD CONSTRAINT USERS_AUTHORITY_FK FOREIGN KEY 
    ( 
     Id_Authority
    ) 
    REFERENCES AUTHORITY 
    ( 
     Id_Authority
    ) 
;