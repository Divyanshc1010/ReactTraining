var employee=(function EmployeeInfo(ename, eage, edesignation, esalary) {
    var employeeName = ename;
    var employeeAge = eage;
    var employeeDesignation = edesignation;
    var employeeSalary = esalary;

    function getName() {
        return employeeName;
    }
    function getAge() {
        return employeeAge;
    }
    function getDesignation() {
        return employeeDesignation;
    }

    return {
        empName: getName,
        empAge: getAge,
        empDesignation: getDesignation
    }
})("Divyansh", 21, "Trainee", 1000)

var uname = employee.empName()
var age = employee.empAge()
var designation = employee.empDesignation()
console.log(uname)
console.log(age)
console.log(designation)

debugger;