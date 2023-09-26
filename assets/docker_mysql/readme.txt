docker build -t mysqlacad:v1 .
docker run -d --name mysqlacad1 -p 3306:3306 mysqlacad:v1
docker exec -it mysqlacad1 mysql -u root -p
    show databases;
    use SysacadDb;
    show tables;