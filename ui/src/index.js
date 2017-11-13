import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import './style/index.scss';
import App from './components/App';
import registerServiceWorker from './registerServiceWorker';
import { createStore } from './createStore';

const initialState = { rift: [null, null]};
const store = createStore(initialState);

ReactDOM.render(
    <Provider store={store}>
        <App />
    </Provider>, 
    document.getElementById('root')
);

registerServiceWorker();