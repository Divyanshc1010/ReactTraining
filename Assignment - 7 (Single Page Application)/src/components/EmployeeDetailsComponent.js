export default function EmployeeDetailsComponent(props) {

    var styleObject =  {
        containerStyle: {
            width: "18rem", 
            margin: "20px", 
            display: "inline-block"
        }
    };
    return (
          <div className="card" style={styleObject.containerStyle}>
              <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS99ZQZ-tALR0HbCOvxhVyV8K8QY6KDgS14Sg&usqp=CAU" className="card-img-top" alt={props.ename} />
              <div className="card-body">
                  <div>
                    <h5 style={styleObject.headerStyling} className="card-title"><b>Employee Name:</b> {props.ename}</h5>
                    <div>
                        <p className="card-text">Employee Id: {props.eid}</p>
                        <p>Date Of Joining: {props.doj}</p>
                        <p>Salary: {props.salary}</p>
                        <p>City: {props.city}</p>
                    </div>
                    <input type="button" id={props.eid} className="btn btn-primary" value="Delete" onClick={props.deleteEmployee} /><br/><br/>
                    <input type="button" name={props.eid} className="btn btn-primary" value="Update" onClick={props.updateEmployee} />
                  </div>
              </div>
          </div>
    )
}