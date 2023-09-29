
\connect branchdb

CREATE TABLE branch
(
    id serial PRIMARY KEY,
    name  VARCHAR (100)  NOT NULL,
    description  VARCHAR (1000)  NOT NULL
);

ALTER TABLE "branch" OWNER TO branchuser;

Insert into branch(name,description) values( 'Connells Hitchin','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
Insert into branch(name,description) values( 'Brown and Merry Woburn','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
Insert into branch(name,description) values( 'Burchell Edwards Putney','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
Insert into branch(name,description) values( 'Paul Dubberley Oxford','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
