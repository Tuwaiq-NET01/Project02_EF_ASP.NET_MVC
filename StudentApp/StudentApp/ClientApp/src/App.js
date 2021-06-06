import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import Headers from './components/Headers'
import Books from './components/Books'
import Student from './components/Student'
import Question from './components/Question'
import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
      return (

             <div>
               <Headers/>
              <Route exact path='/' component={Books} />
              <Route path='/students/:id' component={Student} />
              <Route path='/courses/:id' component={Question} />
              </div>
              
      
    );
  }
}
