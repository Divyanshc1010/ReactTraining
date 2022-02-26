import React from 'react';
import { BrowserRouter, Route, Link } from "react-router-dom";
import EmployeeListComponent from "../classComponent/EmployeeListComponent";
import UpdateEmployeeComponent from "./UpdateEmployeeComponent";
import AddComponent from './AddComponent';

export default class MainComponent extends React.Component {
    constructor() {
        super();
        this.state = {
            userName: ""
        }
    }

    render() {
        return (
            <BrowserRouter>
                <div>
                    <HeaderComponent></HeaderComponent>
                    <ContentComponent></ContentComponent>
                    <FooterComponent></FooterComponent>
                </div>
            </BrowserRouter>
        )
    }
}

function ContentComponent() {
    return (
        <div style={{border: "1px solid red", padding: "10px", margin: "10px", height: "600px", overflow: "auto"}}>
            <Route exact path="/" component={EmployeeListComponent}></Route>
            <Route exact path="/add" component={AddComponent}></Route>
            <Route exact path="/update/:userId" component={UpdateEmployeeComponent}></Route>
        </div>
    )
}

function HeaderComponent() {
    return (
        <div>
            <i><u><h1 style={{color:"red"}}>Employee List Details With Various Functions</h1></u></i>
            <nav>
                {/* <Link style={{margin: "10px"}} to="/add">Add A New Employee</Link> */}
                {/* <input type="button" className="btn btn-primary" value="Add A New Employee"  /> */}
            </nav>
        </div>
    )
}



function FooterComponent() {
    return <></>
}

