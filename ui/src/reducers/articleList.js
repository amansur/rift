import * as actions from '../constants/actions'

export const articleList = (state = [], action) => {
    switch(action.type) {
        case actions.SAVE_URL_SUCCESS:
            return [...state, { url: action.url, title: action.title }];
        case actions.SAVE_URL_FAILURE:
            return state;
        case actions.RECEIVE_ARTICLE_LIST:
            return action.data;
        default:
            return state;
    }
}