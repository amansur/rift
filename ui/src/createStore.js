import * as redux from 'redux';
import thunk from 'redux-thunk';
import * as reducers from '.';

export const configureStore = (initialState) => {
    const reducer = redux.combineReducers({
        ...reducers
    });

    const store = redux.createStore(
        reducer,
        initialState,
        redux.compose(redux.applyMiddleware(thunk))
    );

    return store;
}