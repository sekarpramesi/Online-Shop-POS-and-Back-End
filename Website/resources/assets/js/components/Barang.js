import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';

export default class Barang extends Component {
    constructor(){
        super();
        this.state={
            barang: []
        }
        console.log(super());
    }

    componentWillMount(){
        axios.get('/api/barang').then(response=>{
            this.setState({
                barang:response.data
            });
        }).catch(errors =>{
            console.log(errors);
        })
    }

    render() {
        return (
            <div className="container">
                {this.state.barang.map(brg=><li>{brg.nama_barang}</li>)}
            </div>
        );
    }
}

if (document.getElementById('example')) {
    ReactDOM.render(<Barang />, document.getElementById('example'));
}
