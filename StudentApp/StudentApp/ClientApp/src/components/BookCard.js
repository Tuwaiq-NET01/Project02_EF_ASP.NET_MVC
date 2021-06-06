import React, { Component } from 'react'
import {Redirect} from 'react-router-dom'
export default class BookCard extends Component {


  handleData = (e) => {
    
    window.location.href='/students/'+this.props.info.id

}
  render() {
    return (
      
        <div className="card-container">
        <img src={this.props.info.img} alt=""/>
        <div className="desc">
          <h2>{this.props.info.name}</h2>
          <button  onClick={this.handleData} type="button">Show More</button>                    
        </div>
      </div>
      
    )
  }
}
