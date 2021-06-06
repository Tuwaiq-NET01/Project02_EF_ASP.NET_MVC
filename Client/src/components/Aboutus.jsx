import React from 'react';
import Fade from 'react-reveal/Fade'; 

const Aboutus = () => {
    return (
        <div>
          <section className="text-center mb-5">
              <div className="col-lg-8 mx-auto  py-5">
                  <h2 className="title-h2">About us</h2>
                  <p className="lead mb-0"> This webpage shows the most popular places recommended to any tourist who's planning to visit KSA.</p>
               </div>
          </section>
           

          <section className="mb-0">
          <Fade right duration={2600} delay={100}>
            <div className="row no-gutters">
              <div className="col-lg-6 order-lg-2 "><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Masjid_Nabawi_The_Prophet%27s_Mosque%2C_Madina.jpg/1920px-Masjid_Nabawi_The_Prophet%27s_Mosque%2C_Madina.jpg" alt="paint" className="w-100"/></div>
              <div className="col-lg-6 order-lg-1 my-auto px-5">
                <h2 className="title-h2">Events</h2>
                <p className="lead mb-0">You can visit places , where kids and adults enjoy different activities.!</p>
              </div>
            </div>
          </Fade>
          <Fade left duration={2600} delay={200}>
            <div className="row  no-gutters">
              <div className="col-lg-6 order-lg-1 " ><img src="https://en.vogue.me/image_provider/?w=750&h=&zc=1&q=90&cc=ffffff&src=https://ar.vogue.me/wp-content/uploads/2018/03/Diriyahpic.jpg"alt="paint" className="w-100"/></div>
              <div className="col-lg-6 order-lg-2 my-auto px-5  ">
                <h2 className="title-h2">Explore Heritage sites</h2>
                <p className="lead mb-0 ">Saudi Arabia currently has five World Heritage sites inscribed in the list, namely Al-Ahsa Oasis, Al-Hijr Archaeological Site, At-Turaif District of ad-Dir'iyah, historic Jeddah, and the rock art of the Hail Region..</p>
              </div>
            </div>
          </Fade>
          <Fade right duration={2600} delay={300}>
            <div className="row no-gutters ">
              <div className="col-lg-6 order-lg-2 "><img src= "https://i0.wp.com/alhtoon.com/wp-content/uploads/2018/07/FE1FE1DF-6B9A-4DCA-9066-7FAD12D36C3D.jpeg?w=999&ssl=1" alt="paint" className="w-100"/></div>
              <div className="col-lg-6 order-lg-1 my-auto px-5">
                <h2 className="title-h2"> Nature </h2>
                <p className="lead mb-0"> There are many nature places  in KSA, that could attrack the visitor from overseas .</p>
              </div>
            </div>
            </Fade>
          </section>

          <section id="quotes-section" className="text-center mb-3 py-5">
            <div className="container">
              <div className="row">
              <div className="col-lg-6 mx-auto my-5">
                  <p className="lead mb-0"><q>Help others without any reason and give without the expectation of receiving anything in return.</q><span className="quote-by">― Roy T. Bennett</span></p>
                </div>
                <div className="col-lg-6 mx-auto my-5">
                <p className="lead mb-0"><q>The work of volunteers impacts on all our lives, Even if we are not aware of it.</q><span className="quote-by">― Anthony Worrall-Thompson</span></p>
                </div>
              </div>
            </div>
          </section>

          
          <footer class="footer my-0 py-5 px-3">
              <p class="text-muted small mb-4 mb-lg-0 text-center">&#169; Website 2020. By Riham</p>
          </footer>   
        
         
        </div>
    );
};

export default Aboutus;