import React ,{useEffect, useState} from 'react';
import './details.css';
import axios from 'axios';

 const AddPlace = () => {
    const [placeName, setPlaceName]            = useState("")        
    const [description, setDescription]        = useState("")     
    const [type, settype]                      = useState("other")     
    const [photo, setPhoto]                    = useState("")
    const [cityId, setcityId]                  = useState("")  
    const [cities, setcities] = useState([]);
    const [error, setError] = useState([]);

     // to fetch 
    const [latitude, setLatitude] = useState()
    const [longitude, setLongitude] =useState()
    const [address, setAddress] = useState('')
    const [pid, setpid] = useState('')

    const delay = ms => new Promise(res => setTimeout(res, ms));

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
        .catch((err) => {console.error(err)
        });
  
    }  

    const handleAdd =async(e) => {
        e.preventDefault();
  
       const addPlace={
  
        "placeName": placeName,
        "description": description,
        "type": type,
        "photo": photo,
        "cityId": cityId,
        "address": {
          "longitude": longitude,
          "latitude": latitude
        }
      }
  
         axios
          .post('https://localhost:44351/api/Places', addPlace)
          .then((res) => {
            console.log(addPlace)
              console.log(res)
               setpid(res.data.placeId) 
            } )
          .catch((err) => console.error(err));
    

         await delay(5000);

          const addAddress = {
            "longitude": String(longitude),
            "latitude": String(latitude),
            "placeId" : parseInt(pid)
            
          }
      
      axios
         .post('https://localhost:44351/api/PlacesAddresses/', addAddress)
         .then((res) => {
           console.log(addPlace)
             console.log(res)} ).catch((err) => console.error(err))
    
    

     }

//     await  axios
//       .post('https://localhost:44351/api/Places', addPlace)
//       .then((res) => {
//         console.log(addPlace)
//           console.log(res)
//         //  navigate("/");

//         } )
//       .catch((err) => console.error(err));
//   };


        // searches for new locations
    const findCoordinates = (e) => {
       // e.preventDefault()
       console.log("insid find")
        const encodedAddress = encodeURI(address)

        // fetches data from our api
        axios.get('https://maps.googleapis.com/maps/api/geocode/json',{
        params:{
          address:address,
          key:''
        }
      })
        .then(response => {
            setError("valid value");
            setLatitude(response.data.results[0].geometry.location.lat)
            console.log(latitude)
            setLongitude(response.data.results[0].geometry.location.lng)
            console.log(longitude)

        })
        .catch(err => {console.log(err)
            setError("invalid value");

        })
    }




    


    return (
        <>
      
        <div className = "Dbody" > 
            <div className = "Dcontainer">
                <div className="Dform">
                    <div className="header">
                    <h1>Welcome!</h1>
                            <p>Please provide the place information below.</p>
                    </div> 
                    <form onSubmit={(e) => handleAdd(e)}>                <div className="inputcontainer">
                    <div class="form-group row">
                        <label for="" class="col-sm-2 col-form-label">name</label>
                        <div class="col-sm-10">
                            <input type="" class="form-control" id="" onChange = {(e)=>setPlaceName(e.target.value)} required />
                        </div>
                    </div>
                    <br/>
                    <div class="form-group row">
                        <label for="" class="col-sm-2 col-form-label">description</label>
                        <div class="col-sm-10">
                            <textarea  rows="4" class="form-control" cols="30" onChange = {(e)=>setDescription(e.target.value)}  value = {description} required></textarea>
                        </div>
                    </div>
                    <br />
                    <div class="form-group row">
                        <label for="" class="col-sm-2 col-form-label"> photo Link</label>
                        <div class="col-sm-10">
                            <input type="" class="form-control" id="" onChange = {(e)=>setPhoto(e.target.value)} required />
                    </div>
                    </div>
                    <br />
                    <div className="form-group">
                        <select required className="form-control" value={type} onChange={e =>settype(e.target.value)}  >
                        <option value="" className="hidden" selected="" disabled=""> category </option>   
                                <option  value= "natural attraction">natural attraction </option>
                                <option  value= "event"> event </option>
                                <option  value= "heritage"> heritage</option>
                                <option  value= "phenomenal building">phenomenal building</option>
                                <option  value= "other"> other </option>

                        </select>
                    </div>
                    <br />
                    <div className="form-group">
                        <select className="form-control" value={cityId} onChange={e =>setcityId(e.target.value)} required>
                        <option value="" className="hidden" selected="" disabled="">Please select the region</option>
                            {/* {cities.map((region,i)=>{
                               
                                <option key={i} value={region.cityId}>{region.name}</option>
                    
                            })} */}

                                {cities.map((region, i)=>{
                                            return(
                                            
                                                <option key={i} value={region.cityId} >{region.name}</option>
                                                )
                                            })} 


                        </select>
                    </div>
     

                
                    <label htmlFor="address">Address</label>
                  
             
                    <div  class="form-inline">
                                  <input
                                     type="text"
                                     className=""
                                     id="address"
                                     required
                                     aria-describedby="addressHelp"
                                     value={address}
                                     onChange={(e) => setAddress(e.target.value)} required
                                     />          
                                             
                                 <button className="btn btn-primary mb-2  " type='submit' onClick={(e) => findCoordinates(e)}> find</button>
                                 <label>{error} </label>             
                 </div>
                    <button className="btn  btn-lg" id = "Charbtn" type='submit' >Add</button>

                {/* <button className="btn mb-4  btn-lg btn-block" id = "Charbtn" type='submit' onClick = {handleAdd}>Add</button> */}
            </div>
            </form>
            </div>
            </div>
        </div>


       



      
        </>
      );
 };

 export default AddPlace;





