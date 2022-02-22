export default function EmployeeDetailsComponent(props) {

    var styleObject =  {
        containerStyle: {
            width: "18rem", 
            margin: "20px", 
            display: "inline-block"
        }, headerStyling: {
            color: "red"
        }, buttonStyle: {
            color: "black"
        }
    };

    return (
          <div className="card" style={styleObject.containerStyle}>
              <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS99ZQZ-tALR0HbCOvxhVyV8K8QY6KDgS14Sg&usqp=CAU" className="card-img-top" alt={props.name} />
              <div className="card-body">
                  <div>
                    <h5 style={styleObject.headerStyling} className="card-title">{props.name}</h5>
                    <div>
                        <p className="card-text">Employee Id: {props.id}</p>
                        <p><b>Created At: {props.createdAt}</b></p>
                    </div>
                    <input type="button" style={styleObject.buttonStyle} className="btn btn-primary" value="View More Info" />
                  </div>
              </div>
          </div>
    )
}