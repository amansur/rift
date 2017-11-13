import React from 'react';
import { connect } from 'react-redux';
import * as actions from '../constants/actions';

class ArticleList extends React.Component {
    
    componentDidMount() {
        const { articleList } = this.props;
        if (articleList.length === 0) {
            this.retrieveArticles();
        }
    }

    retrieveArticles = () => {
        const { dispatch } = this.props;

        fetch('http://localhost:5000/api/article', {
            mode: 'cors',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            }
        })
        .then(response => response.json())
        .then(data => dispatch({ type: actions.RECEIVE_ARTICLE_LIST, data }));
    }

    handleOnClick = (id) => {
        const { articleList, dispatch } = this.props;
        console.log(articleList, id);
        const url = articleList.filter(c => c.id === id)[0].url;
        console.log(url);
        dispatch({type: actions.PUSH_TO_RIFT, url });
    }
    
    render() {
        const { articleList } = this.props;

        return (
            <ul>
                {
                    articleList.map((article, ix) => <li key={ix} onClick={() => this.handleOnClick(article.id)}>{ article.title } | { article.url }</li>)
                }
            </ul>
        );
    }
}

export default connect(state => {
    return {
        articleList: state.articleList
    }
}, null)(ArticleList)
