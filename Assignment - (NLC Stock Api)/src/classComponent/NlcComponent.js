import { Component } from "react";
import Axios from "axios";

export default class NlcComponent extends Component {
    constructor() {
        super();
        this.state = {
            data: {}
        }
    }

    render() {
        return (
            <>
                <h3>&nbsp;&nbsp;NLC Stock Price Currently</h3>
                <br />
                <div className="card text-center" style={{ width: '250px', margin: '30px', display: 'inline-block' }}>
                    <div className="card-header">
                        {this.state.data.DISPID} {this.state.data.SC_SUBSEC}
                    </div>
                    <div className="card-body">
                        <h5 className="card-title">{this.state.data.company}</h5>
                        <div class="alert alert-success" role="alert">
                        Average Del Volume Per 20 Days : {this.state.data.AvgDelVolPer_20day}
                        </div>
                        <div class="alert alert-success" role="alert">
                            BIDP : {this.state.data.BIDP}
                        </div>
                        <div class="alert alert-danger" role="alert">

                            Current Price : {this.state.data.pricecurrent}
                        </div>
                        <div class="alert alert-primary" role="alert">
                            Previous Price : {this.state.data.priceprevclose}
                        </div>
                        <div class="alert alert-secondary" role="alert">
                            Price Change :  {this.state.data.pricechange}
                        </div>
                        <div class="alert alert-warning" role="alert">
                            Last Updated At : {this.state.data.lastupd}
                        </div>
                    </div>
                    <div className="card-footer text-muted">
                        Year : {this.state.data.YR}
                    </div>
                </div>
            </>
        )
    }

    componentDidMount() {
        setInterval(()=>{Axios.get("https://priceapi.moneycontrol.com/pricefeed/nse/equitycash/NLC").then((response) => {
            this.setState({ data: response.data.data })
            console.log(this.state.data)
        })},2000)
    }

}
