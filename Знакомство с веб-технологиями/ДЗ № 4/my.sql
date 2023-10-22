CREATE TABLE classmates (
    id INTEGER PRiMARY KEY AUTO_INCREMENT,
    name TEXT NOT NULL,
    age INTEGER NOT NULL,
    address TEXT NOT NULL
);

INSERT INTO classmates (name, age, address) VALUE ('Сергей', '16', 'New-York');
INSERT INTO classmates (name, age, address) VALUE ('Виталий', '25', 'Москва');
INSERT INTO classmates (name, age, address) VALUE ('Диана', '26', 'Москва');
INSERT INTO classmates (name, age, address) VALUE ('Ирина', '30', 'Москва');
INSERT INTO classmates (name, age, address) VALUE ('Иван', '28', 'Саранск');
INSERT INTO classmates (name, age, address) VALUE ('Александр', '24', 'Москва');
INSERT INTO classmates (name, age, address) VALUE ('Юлия', '19', 'Тверь');
INSERT INTO classmates (name, age, address) VALUE ('Наталья', '18', 'Москва');
INSERT INTO classmates (name, age, address) VALUE ('Александр', '22', 'Тюмень');

SELECT name 
FROM classmates
WHERE address = 'Москва' AND age >= '18' AND age < '30'

