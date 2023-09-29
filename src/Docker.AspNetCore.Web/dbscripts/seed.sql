
\connect blogdb

CREATE TABLE blog
(
    id serial PRIMARY KEY,
    title  VARCHAR (100)  NOT NULL,
    description  VARCHAR (1000)  NOT NULL
);

ALTER TABLE "blog" OWNER TO bloguser;

Insert into blog(title,description) values( 'Blog Post 1','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
Insert into blog(title,description) values( 'Blog Post 2','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
Insert into blog(title,description) values( 'Blog Post 3','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
Insert into blog(title,description) values( 'Blog Post 4','Lorem ipsum dolor sit amet consectetur adipiscing elit odio fermentum quam, dignissim dictum vestibulum');
