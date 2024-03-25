# Screenshots

https://centennialcollegeedu-my.sharepoint.com/:b:/g/personal/crosari5_my_centennialcollege_ca/EWzRRjSszltLmhncCWdgHYMBXYcw8v8cGaFFWVX24D1nIw?e=KSBpgl

# Docker-compose file

```yml
version: "3.8"
services:
  db:
    container_name: postgres_container
    image: postgres
    restart: always
    environment:
      POSTGRES_PASSWORD: admin123
      POSTGRES_DB: test_db
    ports:
      - "5430:5432"
  pgadmin:
    container_name: pgadmin4_container
    image: dpage/pgadmin4
    restart: always
    environment:
      PGADMIN_DEFAULT_EMAIL: admin@admin.com
      PGADMIN_DEFAULT_PASSWORD: root
    ports:
      - "5050:80"
```
