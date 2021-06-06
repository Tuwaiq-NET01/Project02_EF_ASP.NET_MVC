import React, { Component } from 'react'
import { useParams } from 'react-router-dom';
import CourseCard from './CourseCard'
import axios from 'axios'
export default class Student extends Component {
    constructor(props) {
        super(props)
        this.state = {
            courses: [],
        }
    }
    componentDidMount(){
        axios({
            method: "get",
            url: "https://localhost:5001/student/"+this.props.match.params.id
        }).then((response) => {
            this.setState({ courses: [...response.data] })
            console.log("resx", [...response.data]);
            console.log("resxx", this.props.match.params.id);
        }).catch((e) => {
            console.log("error", e);
        })
    }
    render() {
        
        return (
            <div className="list">
               {
                    this.state.courses.map((course,i)=>{
                        {console.log(">>>>>"+course.name);}
                        return <CourseCard key={course.id} info={course}/>
                    })
                }
            </div>
        )
    }
}
