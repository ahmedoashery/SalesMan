USE [master]
GO
IF EXISTS(select * from sys.databases where name='products_db') 
ALTER DATABASE products_db SET ONLINE
GO
DROP DATABASE products_db
GO