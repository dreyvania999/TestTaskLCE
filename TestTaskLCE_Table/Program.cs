/*Таблица Employees. Получить список всех сотрудников из 20го и из 30го отдела (department_id)

SELECT EMPLOYEE_ID, FIRST_NAME, LAST_NAME
FROM Employees
WHERE Employees.DEPARTMENT_ID = 20 OR Employees.DEPARTMENT_ID = 30;

Таблицы Employees и Departments. Выведите имя, фамилию и название департамента каждого
сотрудника
SELECT FIRST_NAME, LAST_NAME, DEPARTMENT_NAME
FROM Employees
JOIN Departments ON Employees.DEPARTMENT_ID = Departments.DEPARTMENT_ID
*/