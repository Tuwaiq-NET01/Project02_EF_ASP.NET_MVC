

import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Router, Link, navigate } from '@reach/router';
import Carousel from 'react-elastic-carousel';

const Gallery = () => {
    let [Places, setPlaces] = useState([]);
    useEffect(() => {
        getAlllocations();
     
      }, [ ]);

      
      function getAlllocations() {
     
          axios
          .get('https://localhost:44351/api/Places')
          .then((res) => {
          //  console.log(res2.data);
            setPlaces(res.data) 
            console.log(res.data);

          })
          .catch((err) => console.error(err));
      }
   

      const breakPoints = [
          {width:500, itemsToShow: 1},
          {width:786, itemsToShow: 2},
          {width:1200, itemsToShow: 3},
          {width:1500, itemsToShow: 4}
      ]
    return (

        <div class="card col-md-12 p-3">

      <Carousel breakPoints ={ breakPoints}>
        {Places.map(item => 
        
        // <div key={item.placeId} class="card" >{item.placeName}</div>
<div class="card imgg">
<div class="card-header">{item.placeName}</div>

 
  <img src= {item.photo}  alt="" style={{width: "300px", height:"300px" }} /> 
 
  
 
  <Link to={`/placeDetails/${item.placeId}`}      className="btn btn-warning"   >Disply   </Link>

</div> 
        
        
        )}
      </Carousel>
      </div> 

    )
  }
 export default Gallery;











{/* <div class="card col-md-12 p-3">
<div class="row ">
    <div class="col-md-8">
        <div class="card-block">
            <h6 class="card-title text-right">{PlaceData.placeName}</h6>
            <p class="card-text text-justify">{PlaceData.description}.</p>
            <a href="#" class="btn btn-outline-warning ">read more...</a>
        </div>
    </div>
    <div class="col-md-4">
        <img class="" src={PlaceData.photo} style={{width: "300px", height:"300px" }} />
    </div>
</div>
</div> */}