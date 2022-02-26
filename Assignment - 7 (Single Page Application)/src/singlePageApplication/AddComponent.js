import React,{ Component } from "react";
import axios from "axios";
export default class AddComponent extends Component
{
    constructor(props){
        super(props)
        this.state={
            eid:'',
            ename:'',
            salary:'',
            doj:'',
            city:''
        }
    }

    changeHandler= e =>{
        this.setState({ [e.target.name]: e.target.value })
    }
    submitHandler= e => {
        alert('New Employee Added Successfully !! Refresh To See The Result');
        axios.post("https://localhost:5001/api/Employee/AddEmp", this.state).then(()=>{
             
        })
        this.props.history.push("/")
        
    }
    render(){
        const{eid,ename,salary,doj,city}=this.state
        return(
            <div>
                <form onSubmit={this.submitHandler}>
                    <div>
                    &nbsp;&nbsp;&nbsp;&nbsp;Employee Id: &nbsp;&nbsp;<span></span><input type="text" name="eid" value={eid} onChange={this.changeHandler}/><br/><br/>
                    </div>
                    <div>
                    &nbsp;&nbsp; Employee Name: &nbsp;&nbsp;<input type="text" name="ename" value={ename} onChange={this.changeHandler}/><br/><br/>
                    </div>
                    <div>
                    &nbsp;&nbsp; Employee Salary: &nbsp;&nbsp;<input type="text" name="salary" value={salary} onChange={this.changeHandler}/><br/><br/>
                    </div>
                    <div>
                    &nbsp;&nbsp; Employee Doj: &nbsp;&nbsp;<input type="date" name="doj" value={doj} onChange={this.changeHandler}/><br/><br/>
                    </div>
                    <div>
                    &nbsp;&nbsp; Employee City: &nbsp;&nbsp;<input type="text" name="city" value={city} onChange={this.changeHandler}/><br/><br/>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp;<button type="submit">Submit</button>
                </form>
            </div>
        )
    }
}