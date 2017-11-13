import React, { Component } from 'react';
import ArticleCreator from './ArticleCreator';
import ArticleList from './ArticleList';
import Rift from './Rift';
import '../style/App.scss';

class App extends Component {
  render() {
    return (
      <div className="App">
        <ArticleCreator />
        <ArticleList />
        <Rift />
      </div>
    );
  }
}

export default App;
