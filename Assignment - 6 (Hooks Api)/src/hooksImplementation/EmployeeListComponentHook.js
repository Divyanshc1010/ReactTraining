import Axios from "axios";
import React from "react";
import { useState, useEffect } from "react";
import EmployeeDetailsComponent from "../components/EmployeeDetailsComponent"
export default function GetEmployeeList()
{
    var [employeeList, setEmployeeList] = useState([]);

    useEffect(() => {
            getData()
    }, [])

    function getData()
    {
        
        var dataPromise = Axios.get("https://localhost:5001/api/Employee/AllEmps");
        dataPromise.then((response) => {
            setEmployeeList(response.data);
        })
    }

    function deleteEmployee(event)
    {
        Axios.delete("https://localhost:5001/api/Employee/DeleteEmp?id=" +event.target.id).then(() => {
            alert("Employee is Deleted");
            getData();
        })
    }
    function AddEmployee()
    {
        
        const[eid,setEid]=useState("");
        const[ename,setEname]=useState("");
        const[salary,setSalary]=useState("");
        const[doj,setDoj]=useState("");
        const[city,setCity]=useState("");
        function saveUser()
        {
            // console.warn({eid,ename,salary,doj,city});
            // fetch("https://localhost:5001/api/Employee/AddEmp",{
            //     method:'POST',
            //     headers:{
            //         'Accept':'application/json',
            //         'Content-Type':'application/json'
            //     },
            //     body:JSON.stringify(data)
            // })
            let data={eid,ename,salary,doj,city};
            alert('New Employee Added Successfully !! Refresh To See The Result');  
            Axios.post("https://localhost:5001/api/Employee/AddEmp", data).then(()=>{
                    getData();
            })
        }
        return (
            <div>
                <div>
                &nbsp;&nbsp;&nbsp;&nbsp;Employee Id: &nbsp;&nbsp;<span></span><input type="text" name="eid" value={eid} onChange={(e)=>{setEid(e.target.value)}}/><br/><br/>
                </div>
                <div>
                &nbsp;&nbsp; Employee Name: &nbsp;&nbsp;<input type="text" name="ename" value={ename} onChange={(e)=>{setEname(e.target.value)}}/><br/><br/>
                </div>
                <div>
                &nbsp;&nbsp; Employee Salary: &nbsp;&nbsp;<input type="text" name="salary" value={salary} onChange={(e)=>{setSalary(e.target.value)}}/><br/><br/>
                </div>
                <div>
                &nbsp;&nbsp; Employee Doj: &nbsp;&nbsp;<input type="date" name="doj" value={doj} onChange={(e)=>{setDoj(e.target.value)}}/><br/><br/>
                </div>
                <div>
                &nbsp;&nbsp; Employee City: &nbsp;&nbsp;<input type="text" name="city" value={city} onChange={(e)=>{setCity(e.target.value)}}/><br/><br/>
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp;<button type="button" onClick={saveUser}>Save New Employee</button>
        </div>
        )
    }

    //UPDATE EMPLOYEE DETAILS
    function Edit(){
        const[eid,setEid]=useState("");
        const[ename,setEname]=useState("");
        const[salary,setSalary]=useState("");
        const[doj,setDoj]=useState("");
        const[city,setCity]=useState("");

        function UpdateUser(){
            let data={eid,ename,salary,doj,city};
            alert('Employee Updated Successfully !! Refresh To See The Result'); 
            Axios.put("https://localhost:5001/api/Employee/EditEmp?id="+eid,data).then(()=>{
                getData();
        })
        }
        return(
            <div>
                 &nbsp;&nbsp; Employee ID: <input type="text" value={eid} onChange={(e)=>{setEid(e.target.value)}} placeholder="Eid"/><br/><br/>
                &nbsp;&nbsp; Employee Name: <input type="text" value={ename} onChange={(e)=>{setEname(e.target.value)}} placeholder="Name"/><br/><br/>
                &nbsp;&nbsp; Employee Salary: <input type="text" value={salary} onChange={(e)=>{setSalary(e.target.value)}} placeholder="Salary"/><br/><br/>
                &nbsp;&nbsp; Employee Doj:<input type="date" value={doj} onChange={(e)=>{setDoj(e.target.value)}} placeholder="Doj"/><br/><br/>
                &nbsp;&nbsp; Employee City:<input type="text" value={city} onChange={(e)=>{setCity(e.target.value)}} placeholder="City"/><br/><br/>
                &nbsp;&nbsp; <button onClick={UpdateUser}>Update User Details</button>
            </div>
        )
    }

    return(
        <div>
        <h1>Employee List is given Below:</h1>
        <h2>Add A New Employee</h2>
        <AddEmployee></AddEmployee>  
        <br/><br/>
        <h2>Edit Employee Details</h2>
        <Edit></Edit>
        {/* <button type="button" onClick={demo}>Demo</button>  */}
        {employeeList.map((employee) => {
            
            return <EmployeeDetailsComponent key={employee.eid} {...employee} deleteEmployee={deleteEmployee}></EmployeeDetailsComponent>
        })}  
        
    </div>
    )
   
}

