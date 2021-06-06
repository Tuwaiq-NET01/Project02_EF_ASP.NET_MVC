import React, { useState, useEffect } from 'react';
import axios from 'axios';

// const PlaceDetails = (props) => {

//     let [Places, setPlaces] = useState();
//     useEffect(() => {
//         getAll();
     
//       }, [ ]);

//     function getAll() {
//           axios
//           .get("https://localhost:44351/api/Places/1")
//           .then((res) => {
//            console.log(res.data);
//             setPlaces(res.data) 
//           })
//           .catch((err) => console.error(err));
    
    
    
//       }
//     return (
    

//         </div>
//     )
// };

// export default PlaceDetails;









{/* <div className = "container-sm">
<p>  hi {props.pk}  </p>

        <div class="card col-md-12 p-3">
        <div class="row ">
            <div class="col-md-8">
                <div class="card-block">
                    <h6 class="card-title text-right">{Places.placeName}</h6>
                    <p class="card-text text-justify">{Places.description}.</p>
                    <a href="#" class="btn btn-primary">read more...</a>
                </div>
            </div>
            <div class="col-md-4">
                <img class="" src={Places.photo} style={{width: "300px", height:"300px" }} />
            </div>
        </div>
    </div> */}




const PlaceDetails = (props) => {
   

    const [PlaceData, setPlaceData] = useState([])
    const [CityInfo, setCityInfo] = useState([])



    useEffect(() => {
      getPlaceInfo();
  
    },[ ]);
    
    const getPlaceInfo=()=>{
      axios
      .get(`https://localhost:44351/api/Places/${props.pk}/?format=json`)
      .then((res) => {
          setPlaceData(res.data)
          console.log(res.data)
        })
      .catch((err) => console.error(err));
    }
    
    
    const readmore=()=>{
        axios
        .get(`https://localhost:44351/api/Cities/${PlaceData.cityId}`)
        .then((res) => {
          setCityInfo(res.data)
            console.log(res.data)
          })
        .catch((err) => console.error(err));
      }



      const SubmitComments=()=>{
       
      }

    return (
        
        <div className="container-md position-absolute top-50 start-50 translate-middle">
        {/* <p>hi {props.pk}</p> */}
        <div class="card col-md-12 p-3">
        <div class="row ">
            <div class="col-md-8">
                <div class="card-block">
                    <h6 class="card-title text-right">{PlaceData.placeName}</h6>
                    <p class="card-text text-justify">{PlaceData.description}.</p>
                    <button class="btn btn-secondary" type="button" onClick = {readmore}>more information</button>
                </div>

                <div>
                  <p>{CityInfo.name}</p>
                  <p>{CityInfo.description}</p>
                  <p>{CityInfo.Population}</p>

                  <p></p>

                </div>
            </div>
            <div class="col-md-4">
                <img class="" src={PlaceData.photo} style={{width: "300px", height:"300px" }} />
            </div>
        </div>
    </div>

    <div class="input-group mb-3">
  <input type="text" class="form-control" placeholder="Comment" aria-label="Recipient's username" aria-describedby="basic-addon2"/>
  <div class="input-group-append">
    <button class="btn btn-outline-secondary" type="button" onClick = {SubmitComments}>submit</button>
  </div>
</div>

    <div class="dialogbox">
    <div class="dbody">
      <span class="tip tip-up"></span>
      <div class="message">
        <span>I just made a comment about this comment box which is purely made from CSS.</span>
      </div>
    </div>
  </div>        

        </div>
    )
};

export default PlaceDetails;
