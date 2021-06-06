import React , {useState} from 'react';
import {Link}  from '@reach/router';
import Map from './Map';

import {withGoogleMap, withScriptjs,GoogleMap, MarkerInfoWindow} from "react-google-maps";
const MapWrapped = withScriptjs(withGoogleMap(Map));

const Home = (props) => {
 
    return (
        <>
     
     <div className = "col-10 mx-auto" >
            <div className="mb-5 bg-black rounded mt-3" style={{ width: "80vw", height: "80vh"}}>
              <MapWrapped
                  googleMapURL={`https://maps.googleapis.com/maps/api/js?v=3.exp&libraries=geometry,drawing,places&key=`}
                  loadingElement={<div style={{ height: `100%` }} />}
                  containerElement={<div style={{ height: `100%` }} />}
                  mapElement={<div style={{ height: `100%` }} />}
                />
          </div> 
          </div> 
         
        </>
    );
};
export default Home;