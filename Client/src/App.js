import React from 'react';
import { Router, Link, navigate } from '@reach/router';
import axios from 'axios';
import Home from './components/Home';
import PlaceDetails from './components/PlaceDetails'
import 'bootstrap/dist/css/bootstrap.min.css';
import Gallery from './components/Gallery'
import Aboutus from './components/Aboutus'
import AddPlace from './components/AddPlace'
import Test from './components/Test'

function App() {
  return (
    
    <div className="">
      <nav class="navbar navbar-expand-md navbar-dark ">
  
    <div class="navbar-collapse collapse" id="navbar4">
        <ul class="navbar-nav">
         
            <li className="nav-item"><Link className ="nav-link pr-3 nav-item-home" to="/">Map </Link></li> 
            <li className="nav-item"><Link className ="nav-link pr-3 nav-item-home" to="/gallery">Gallery </Link></li>
            <li className="nav-item"><Link className ="nav-link pr-3 nav-item-home" to="/addplace">Add </Link></li>
            <li className="nav-item"><Link className ="nav-link pr-3 nav-item-home" to="/aboutus">About us </Link></li>
            {/* <li className="nav-item"><Link className ="nav-link pr-3 nav-item-home" to="/test">test </Link></li> */}

        </ul>
    </div>
</nav>
      	<Router>
				<Home path="/"  />
        <Gallery path="/gallery"  />
        <Aboutus path="/aboutus"  />
        <AddPlace path="/addplace"  />
        <Test path="/test"  />
        <PlaceDetails path ="/placeDetails/:pk"  />
			</Router>
    </div>
  );
}

export default App;
