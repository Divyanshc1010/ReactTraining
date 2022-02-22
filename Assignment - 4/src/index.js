import ReactDOM from "react-dom";
import employeeList from "./data/employeeList";
import App from "./components/EmployeeListComponent";

ReactDOM.render(<App empList={employeeList}></App>, document.getElementById("root"))
