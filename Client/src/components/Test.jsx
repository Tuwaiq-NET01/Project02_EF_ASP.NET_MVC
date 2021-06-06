
import React, { useState, useEffect } from 'react';
import axios from 'axios';

const  Test = () =>{

      // to fetch data 
  const [cities, setcities] = useState([]);
 
  useEffect(() => {
    getAllCities();
 
  }, [ ]);


  function getAllCities() {
    axios
      .get('https://localhost:44351/api/Cities')
      .then((res) => {
      //  console.log(res.data);
      setcities(res.data) 
       
      })
      .catch((err) => console.error(err));


    



  }
  


    return (
      <div>
  
        
    <p>the dta</p>

{cities.map((region, idx)=>{
            return(
            
             <p> {region.name}  "the name is"   </p>
                )
            })} 

      




{/* {Places.map((place, idx)=>{
    return(

     <p> {place.placeName}  </p>
        )
    })} */}

</div> 

    );
    }

export default Test;

