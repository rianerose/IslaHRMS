USE hotel_hrms;

INSERT INTO employees (employee_code, first_name, last_name, email, phone_number, position, department, hire_date, basic_salary, is_active)
VALUES
('EMP001', 'Amelia', 'Smith', 'amelia.smith@example.com', '+15551234567', 'HR Manager', 'HR', '2018-03-12', 45000.00, 1),
('EMP002', 'Carlos', 'Reyes', 'carlos.reyes@example.com', '+15557654321', 'Front Desk Associate', 'Front Office', '2020-06-01', 24000.00, 1),
('EMP003', 'Hanna', 'Lee', 'hanna.lee@example.com', '+15559871234', 'Sous Chef', 'Food & Beverage', '2019-10-15', 28000.00, 1);

INSERT INTO attendance (employee_id, attendance_date, check_in_time, check_out_time, notes)
VALUES
(1, '2025-11-01', '2025-11-01 08:55:00', '2025-11-01 17:05:00', 'Monthly review'),
(2, '2025-11-01', '2025-11-01 07:58:00', '2025-11-01 16:10:00', NULL),
(3, '2025-11-01', '2025-11-01 10:00:00', '2025-11-01 19:15:00', 'Banquet prep');
