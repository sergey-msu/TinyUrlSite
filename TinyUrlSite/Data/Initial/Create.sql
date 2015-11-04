﻿DROP DATABASE IF EXISTS TinyUrlDB;

CREATE DATABASE TinyUrlDB;

USE TinyUrlDB;

CREATE TABLE UrlMap
(
  id VARCHAR(100),
  URL VARCHAR(8000),
  PRIMARY KEY (id)
);