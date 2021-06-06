import React, { Component } from 'react'
import SearchArea from './SearchArea'
import BookList from './BookList'
import axios from 'axios'
export default class Books extends Component {
    constructor(props) {
        super(props)
        this.state = {
            books: [],
            searchFiled: ''
        }
    }
    componentDidMount(){
        axios({
            method: "get",
            url: "https://localhost:5001/Student" 
        }).then((response) => {
            this.setState({ books: [...response.data] })
            console.log("res", [...response.data]);
        }).catch((e) => {
            console.log("error", e);
        })
    }
    handleData = (e) => {
        e.preventDefault();
        axios({
            method: "get",
            url: this.props.URL
        }).then((response) => {
            this.setState({ books: [...response.data] })
            console.log("res", [...response.data]);
        }).catch((e) => {
            console.log("error", e);
        })

    }
    handleSearch = (e) => {
        console.log(e.target.value);
        this.setState({
            searchFiled: e.target.value
        })
    }
    render() {
        
        return (
            <div className="wrapper">
                {/* <SearchArea handleSearch={this.handleSearch} handleData={this.handleData} /> */}
                <BookList books={this.state.books} />
               
            </div>
        )
    }
}
