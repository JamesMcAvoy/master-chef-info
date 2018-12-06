/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: ingredients
------------------------------------------------------------*/
CREATE TABLE ingredients(
    id             INT IDENTITY (1,1) NOT NULL ,
    name           VARCHAR (50) NOT NULL ,
    stock          INT  NOT NULL ,
    preservation   VARCHAR CHECK (preservation IN ('frozen product','fresh product','long lasting product')),
    CONSTRAINT ingredients_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: recipes
------------------------------------------------------------*/
CREATE TABLE recipes(
    id                 INT IDENTITY (1,1) NOT NULL ,
    description        TEXT  NOT NULL ,
    preparation_time   INT  NOT NULL ,
    cooking_time       INT  NOT NULL ,
    sleeping_time      INT  NOT NULL ,
    type               VARCHAR CHECK (type IN ('entree','dish','dessert'))  ,
    stock              INT  NOT NULL  ,
    CONSTRAINT recipes_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: list
------------------------------------------------------------*/
CREATE TABLE list(
    id               INT  NOT NULL ,
    id_ingredients   INT  NOT NULL ,
    number           INT  NOT NULL  ,
    CONSTRAINT list_PK PRIMARY KEY (id,id_ingredients)

    ,CONSTRAINT list_recipes_FK FOREIGN KEY (id) REFERENCES recipes(id)
    ,CONSTRAINT list_ingredients0_FK FOREIGN KEY (id_ingredients) REFERENCES ingredients(id)
);