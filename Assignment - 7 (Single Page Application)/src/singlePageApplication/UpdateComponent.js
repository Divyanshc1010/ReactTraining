import Axios from 'axios';
import React from 'react';

export default class UpdateComponent extends React.Component {
    constructor() {
        super();
        this.state = {
            name: "",
            id: "",
            createdAt: "Today",
            avatar: "https://www.insureon.com/-/media/blog/posts/2021/photo_group-of-employees-working-on-project.png?h=370&iar=0&w=750&rev=3faabd3c0f7c4e11966caaa037fa4fc8"
        }
    }

    render() {
        debugger;
        return (
            <div>
                Name: <input type="text" value={this.state.name} /><br/><br/>
                Id: <input type="text" value={this.state.id} /><br/><br/>
                CreatedAt: <input type="text" value={this.state.createdAt} /><br/><br/>
                <input type="button" value="Submit" onClick={this.updateEmployee} />
            </div>
        )
    }

    updateEmployee = () => {
        // Have some Put Request...
    }

    componentDidMount() {
        alert(this.props.match.params.userId);
        Axios.get("https://localhost:5001/api/Employee/AllEmps" + this.props.match.params.userId).then((response) => {
            this.setState({
                name: response.data.name,
                createdAt: response.data.createdAt,
                id: response.data.id
            })
        })
    }
}