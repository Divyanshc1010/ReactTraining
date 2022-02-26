import Axios from 'axios';
import React from 'react';

export default class UpdateEmployeeComponent extends React.Component {
    constructor() {
        super();
        this.state = {
            ename: "",
            eid: "",
            doj: "",
            //avatar: "https://www.insureon.com/-/media/blog/posts/2021/photo_group-of-employees-working-on-project.png?h=370&iar=0&w=750&rev=3faabd3c0f7c4e11966caaa037fa4fc8"
            salary:"",
            city:""
        }
    }
    changeHandler= e =>{
        this.setState({ [e.target.name]: e.target.value })
    }
    updateEmployee = e => {
        
        
        alert('Employee Updated Successfully !! Refresh To See The Result'); 
        Axios.put("https://localhost:5001/api/Employee/EditEmp?id="+this.state.eid,this.state).then(()=>{
            
         })
         this.props.history.push("/");
        
    }

    render() {
        
        return (
            <div>
               Employee Name: <input type="text" name="ename" value={this.state.ename} onChange={this.changeHandler}/><br/><br/>
                Employee Id: <input type="text" name="eid" value={this.state.eid} onChange={this.changeHandler}/><br/><br/>
                Employee Doj: <input type="text" name="doj" value={this.state.doj} onChange={this.changeHandler} /><br/><br/>
                Employee Salary: <input type="text" name="salary" value={this.state.salary} onChange={this.changeHandler}/><br/><br/>
                Employee City: <input type="text" name="city" value={this.state.city} onChange={this.changeHandler}/><br/><br/>
                <input type="button" value="Submit" onClick={this.updateEmployee} />
            </div>
        )
    }


    componentDidMount() {
        // alert(this.props.match.params.userId);
        Axios.get("https://localhost:5001/api/Employee/EmpById/" + this.props.match.params.userId).then((response) => {
            this.setState({
                ename: response.data.ename,
                doj: response.data.doj,
                eid: response.data.eid,
                salary: response.data.salary,
                city: response.data.city

            })
        })
    }
}