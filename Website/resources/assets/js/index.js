import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import {BrowserRouter as Router,Link,Route} from 'react-router-dom';
import Barang from './components/Barang';
import Example from './components/Example';

export default class Index extends Component {
    render() {
        return (
            <div className="container">
                <Router>
                    <div>
                        <Link to ="/">Home</Link>
                        <Link to="/barang">Barang</Link>
                        <Route path="/" component={Example}/>
                        <Route path="/barang" component={Barang}/>
                    </div>
                </Router>
            </div>
        );
    }
}

if (document.getElementById('example')) {
    ReactDOM.render(<Index />, document.getElementById('example'));
}
