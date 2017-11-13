import * as actions from '../constants/actions';

export const rift = (state = [null, null], action) => {
    switch(action.type) {
        case actions.PUSH_TO_RIFT:
            if (state[0] === null && state[1] === null) {
                return [action.url, null];
            } else if (state[0] === null && state[1] !== null) {
                return [action.url, state[1]];
            } else if (state[0] !== null && state[1] === null) {
                return [state[0], action.url];
            } else {
                return [state[1], action.url];
            }
        default:
            return state;
    }
}