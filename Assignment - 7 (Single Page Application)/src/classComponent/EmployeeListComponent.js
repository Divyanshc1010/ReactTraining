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
                <h1><i>Employee List is given Below:</i></h1><br></br>
                <h2> &nbsp;Add A New Employee</h2>
                <input type="button" className="btn btn-primary" value="Add A New Employee" onClick={this.newUser} /><br/><br/><hr></hr>
                {this.state.employeeList.map((employee) => {
                    
                    return <EmployeeDetailsComponent key={employee.id} {...employee} updateEmployee={this.updateEmployee} deleteEmployee={this.deleteEmployee}></EmployeeDetailsComponent>
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
    newUser=()=>{
        this.props.history.push("/add")
    }

    updateEmployee = (event) => {
        debugger;
        var employeeId = event.target.name;
        this.props.history.push("/update/" + employeeId);
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