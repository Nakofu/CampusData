DROP TABLE participants;
CREATE TABLE participants (
    month VARCHAR(255),
    amount INTEGER NOT NULL
);
SELECT * FROM participants;


CREATE TABLE attendancemobile (
    month VARCHAR(255) PRIMARY KEY,
    amount INTEGER NOT NULL
);

CREATE TABLE attendanceweb (
    month VARCHAR(255) PRIMARY KEY,
    amount INTEGER NOT NULL
);

CREATE TABLE honours (
    month VARCHAR(255) PRIMARY KEY,
    amount INTEGER NOT NULL
);

CREATE TABLE applications (
    month VARCHAR(255) PRIMARY KEY,
    amount INTEGER NOT NULL
);

CREATE TABLE fundstipend (
    month VARCHAR(255) PRIMARY KEY,
    amount INTEGER NOT NULL
);

CREATE TABLE fundprivilege (
    month VARCHAR(255) PRIMARY KEY,
    amount INTEGER NOT NULL
);

CREATE TABLE fundbonus (
    month VARCHAR(255) PRIMARY KEY,
    amount INTEGER NOT NULL
);

CREATE TABLE schools (
    name VARCHAR(255) PRIMARY KEY,
    students VARCHAR(255) NOT NULL,
    honours VARCHAR(255) NOT NULL,
    applicants VARCHAR(255) NOT NULL
);

CREATE TABLE majors (
    name VARCHAR(255) PRIMARY KEY,
    students VARCHAR(255) NOT NULL
);

CREATE TABLE pages (
    name VARCHAR(255) PRIMARY KEY,
    time INTEGER NOT NULL,
    percentage INTEGER NOT NULL
);

CREATE TABLE regions (
    name VARCHAR(255) PRIMARY KEY,
    users VARCHAR(255) NOT NULL,
    percentage INTEGER NOT NULL
);