CREATE DATABASE IF NOT EXISTS hotel_hrms CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE hotel_hrms;

CREATE TABLE IF NOT EXISTS employees (
    id INT AUTO_INCREMENT PRIMARY KEY,
    employee_code VARCHAR(50) NOT NULL UNIQUE,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    email VARCHAR(150) NULL,
    phone_number VARCHAR(50) NULL,
    position VARCHAR(100) NULL,
    department VARCHAR(100) NULL,
    hire_date DATE NOT NULL,
    basic_salary DECIMAL(12,2) NOT NULL DEFAULT 0,
    is_active TINYINT(1) NOT NULL DEFAULT 1,
    last_modified DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    INDEX idx_employees_department (department),
    INDEX idx_employees_is_active (is_active)
);

CREATE TABLE IF NOT EXISTS attendance (
    id INT AUTO_INCREMENT PRIMARY KEY,
    employee_id INT NOT NULL,
    attendance_date DATE NOT NULL,
    check_in_time DATETIME NULL,
    check_out_time DATETIME NULL,
    notes VARCHAR(500) NULL,
    created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    CONSTRAINT fk_attendance_employee FOREIGN KEY (employee_id) REFERENCES employees(id) ON DELETE CASCADE,
    UNIQUE KEY uq_employee_day (employee_id, attendance_date)
);

CREATE TABLE IF NOT EXISTS payroll (
    id INT AUTO_INCREMENT PRIMARY KEY,
    employee_id INT NOT NULL,
    employee_name VARCHAR(200) NOT NULL,
    pay_period_start DATE NOT NULL,
    pay_period_end DATE NOT NULL,
    base_hours_worked DECIMAL(8,2) NOT NULL DEFAULT 0,
    overtime_hours DECIMAL(8,2) NOT NULL DEFAULT 0,
    base_pay DECIMAL(12,2) NOT NULL DEFAULT 0,
    overtime_pay DECIMAL(12,2) NOT NULL DEFAULT 0,
    gross_pay DECIMAL(12,2) NOT NULL DEFAULT 0,
    total_deductions DECIMAL(12,2) NOT NULL DEFAULT 0,
    taxes DECIMAL(12,2) NOT NULL DEFAULT 0,
    net_pay DECIMAL(12,2) NOT NULL DEFAULT 0,
    generated_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    notes VARCHAR(500) NULL,
    CONSTRAINT fk_payroll_employee FOREIGN KEY (employee_id) REFERENCES employees(id) ON DELETE CASCADE,
    INDEX idx_payroll_period (pay_period_start, pay_period_end)
);

CREATE TABLE IF NOT EXISTS payroll_deductions (
    id INT AUTO_INCREMENT PRIMARY KEY,
    payroll_id INT NOT NULL,
    description VARCHAR(150) NOT NULL,
    amount DECIMAL(12,2) NOT NULL DEFAULT 0,
    CONSTRAINT fk_deductions_payroll FOREIGN KEY (payroll_id) REFERENCES payroll(id) ON DELETE CASCADE
);
