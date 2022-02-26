import EmployeeDetailsComponent from "./EmployeeDetailsComponent";
import "../styles/EmployeeListComponentStyle.css";
import { useState } from "react";

export default function EmployeeListComponent(props) {
    const[searchTerm,setSearchTerm]=useState("")
    return (
        <div>
            <h1>Employee List is Given Below...</h1>
            <input type="text" id="in1" placeholder="Search..." onChange={(event)=>{setSearchTerm(event.target.value);}}/>
            <div>
                {props.empList.filter((employee)=>
                {
                    if(searchTerm=="")
                    {
                        return employee
                    }
                    else if(employee.name.toLowerCase().includes(searchTerm.toLowerCase()))
                    {
                        return employee
                    }
                }).map(function(employee) {
                    return (
                        <EmployeeDetailsComponent key={employee.id} {...employee}></EmployeeDetailsComponent>
                    );
                })}
            </div>
        </div>
    )
}