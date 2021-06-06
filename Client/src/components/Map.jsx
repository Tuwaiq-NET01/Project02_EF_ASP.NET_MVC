import React, { useState, useEffect } from 'react';
import axios from 'axios';
import {
    withGoogleMap,
    withScriptjs,
    GoogleMap,
    Marker,
    InfoWindow
  } from "react-google-maps";


  import { Router, Link, navigate } from '@reach/router';


const  Map = () =>{

      // to fetch data 
  const [locations, setLoc] = useState([]);
  let [Places, setPlaces] = useState([]);
  const [selectedLabel, setSelLabel] = useState();
  const [selectedPlace, setselectedPlace] = useState();
   let x = null;
  let [place, setPlc] = useState();

  useEffect(() => {
    getAlllocations();
 
  }, [ ]);

  const placeFunc = (id) =>{
    for (const p in Places) 
    {
     if (id === Places[p].placeId ){
             console.log( Places[p].placeName) 
             return Places[p]
          }
                
   }

  }
  function findPlace( id){
   // const result = Places.find( ({ placeId }) => placeId === id );
   // console.log(result);
 
   // return result.name;
  // console.log(id) 
   for (const p in Places) 
   {
    if (id === Places[p].placeId ){
            console.log( Places[p].placeName) 
            x = Places[p];
            return Places[p]
         }
           
          
  }
  }


  function getAlllocations() {
    axios
      .get('https://localhost:44351/api/PlacesAddresses')
      .then((res) => {
      //  console.log(res.data);
        setLoc(res.data) 
      })
      .catch((err) => console.error(err));


      axios
      .get('https://localhost:44351/api/Places')
      .then((res2) => {
      //  console.log(res2.data);
        setPlaces(res2.data) 
      })
      .catch((err) => console.error(err));



  }
  

const mapStyle =  [
    {
        "featureType": "all",
        "elementType": "labels.text",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "all",
        "elementType": "labels.icon",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "landscape",
        "elementType": "geometry.fill",
        "stylers": [
            {
                "color": "#f1efe8"
            }
        ]
    },
    {
        "featureType": "landscape.man_made",
        "elementType": "geometry.fill",
        "stylers": [
            {
                "visibility": "on"
            },
            {
                "gamma": "1.19"
            }
        ]
    },
    {
        "featureType": "landscape.man_made",
        "elementType": "geometry.stroke",
        "stylers": [
            {
                "visibility": "on"
            },
            {
                "gamma": "0.00"
            },
            {
                "weight": "2.07"
            }
        ]
    },
    {
        "featureType": "road.highway",
        "elementType": "geometry.fill",
        "stylers": [
            {
                "color": "#b2ac83"
            }
        ]
    },
    {
        "featureType": "road.highway",
        "elementType": "geometry.stroke",
        "stylers": [
            {
                "color": "#b2ac83"
            }
        ]
    },
    {
        "featureType": "water",
        "elementType": "geometry.fill",
        "stylers": [
            {
                "color": "#8ac0c4"
            }
        ]
    }
]
    return (
      <div>
  <GoogleMap
        defaultZoom={5}
        defaultCenter={{ lat: 23.885942, lng: 45.079163 }}
        options={{
            styles: mapStyle,
        }}
        
        
    >
   {/* {location.longitude}, {location.latitude} */}
  

{locations.map((location, idx)=>{
            return(
              
<Marker  key={idx}
          position={{
            lat: parseFloat (location.latitude) ,
            lng:  parseFloat (location.longitude)
          }}

          onClick={() => {
            // setSelLabel(location);
            setSelLabel(location.placeId);

          }}
          icon={{
            url: `/icons8-marker-16.png`,
            scaledSize: new window.google.maps.Size(25, 25)
          }}
 />
           
 )
            })}

{selectedLabel && (
        <InfoWindow
          onCloseClick={() => {
            setSelLabel(null);
          }}
          position={{
            lat: parseFloat (selectedLabel.latitude) ,
            lng:  parseFloat (selectedLabel.longitude)
          }}
        >
          <div>
              
            <h4>Name:{findPlace(selectedLabel).placeName} </h4>
            {/* <Link to={`/placeDetails/${findPlace(selectedLabel.placeId).placeName}/${x.description}`}      className="btn btn-outline-success btn-sm"   >Disply   </Link> */}
            <Link to={`/placeDetails/${selectedLabel}`}       className="btn btn-warning"   >Disply   </Link>

            <p>info ......</p>
          </div>
        </InfoWindow>
      )}
      
</GoogleMap>




{/* {locations.map((location, idx)=>{
            return(
            
             <p> {location.latitude}  "the name is"  {findPlace(location.placeId).placeName}  </p>
                )
            })} */}

      




{/* {Places.map((place, idx)=>{
    return(

     <p> {place.placeName}  </p>
        )
    })} */}

</div> 

    );
    }

export default Map;



{/* <div>
{locations.map((location, idx)=>{
                // return <p key={idx}>  {product.title}, {product.price}</p>
return <p key={idx}>  {location.longitude}, {location.latitude}   </p>
                
            })}
</div> */}


// position={{
//     lat: 25.308362636640986 ,
//     lng:  46.49374750289468
//   }}




   {/* {location.longitude}, {location.latitude} */}
  

//    {locations.map((location, idx)=>{
//     return(
//       <>
//         <p key={idx}>lon: {location.longitude}</p>

//       </>
//     )
//     })}



// </div> 
// );
// }