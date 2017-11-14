import React from 'react';
import { connect } from 'react-redux';
import * as actions from '../constants/actions';

class ArticleCreator extends React.Component {
    constructor(props) {
        super(props);
        this.state = { url: '', title: '' };
    }
    
    onUrlChange = (e) => {
        const val = e.target.value;
        this.setState({ url: val });
    }

    onTitleChange = (e) => {
        const val = e.target.value;
        this.setState({ title: val });
    }

    onSave = (e) => {
        if(this.saveToDb(this.state.url, this.state.title)) {
            this.setState( { title: '', url: '' });
        }

    }

    saveToDb = (url, title) => {
        const { dispatch } = this.props;
        fetch('http://api.nsur.org:5000/api/article', {
            method: 'POST',
            mode: 'cors',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ url, title })
        })
        .then(response => response.json())
        .then(data => data 
            ? dispatch({ type: actions.SAVE_URL_SUCCESS, url, title }) 
            : dispatch({type: actions.SAVE_URL_FAILURE }));

        return true;
    }

    render() {
        return (
            <div>
                <h1>Add an article</h1>
                <div>
                    <label htmlFor="url">URL</label>
                    <input type="text" name="url" value={this.state.url} onChange={this.onUrlChange} />
                </div>
                <div>
                    <label htmlFor="title">Title</label>
                    <input type="text" name="title" value={this.state.title} onChange={this.onTitleChange} />
                </div>
                <div>
                    <input type="button" value="Save" onClickCapture={this.onSave} />
                </div>
            </div>
        )
    }
}

export default connect()(ArticleCreator);