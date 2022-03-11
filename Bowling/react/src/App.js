import React, {Component} from 'react';
import logo from './logo.png';
import './App.css';
import RollBoard from './RollButtons';
import ScoreBoard from './ScoreBoard';

class App extends Component {
  render() {
    return (
      <div className="App">
        <div className="App-header">
          <img src={logo} className="App-logo" alt="logo"/>
          <h2>Welcome to React Bowling</h2>
        </div>
        <RollBoard/>
        <ScoreBoard/>
      </div>
    );
  }
}

export default App;
