import React from 'react';
import Axios from "axios"
import PostForm from './PostForm';
import EmployeeDetailsComponent from "../components/EmployeeDetailsComponent"

export default class EmployeeListComponent extends React.Component {
    constructor() {
        super();
        this.state = {
            employeeList: []
        }
    }

    render() {
        debugger;
        return (
            <div>
                <h1>Employee List is given Below:</h1>
                <h2> &nbsp;Add A New Employee</h2>
                <PostForm></PostForm>
                {this.state.employeeList.map((employee) => {
                    
                    return <EmployeeDetailsComponent key={employee.eid} {...employee} deleteEmployee={this.deleteEmployee}></EmployeeDetailsComponent>
                })}  
                
            </div>
        )
    }
    

    deleteEmployee = (event) => {
        debugger;
        Axios.delete("https://localhost:5001/api/Employee/DeleteEmp?id=" + event.target.id).then(() => {
            alert("Employee is Deleted");
            this.getData();
        })
    }

    componentDidMount() {
        this.getData();
    }

    getData = () => {
        var dataPromise = Axios.get("https://localhost:5001/api/Employee/AllEmps");
        dataPromise.then((response) => {
            this.setState({
                employeeList: response.data
            })
        })
    }
}

// Create a form which takes Name, id, createdAt and Avatar as Input, Add data to your database.. (Post Request)