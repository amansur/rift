import React from 'react';
import { connect } from 'react-redux';
import '../style/Rift.scss';

class Rift extends React.Component {

    render() {
        const { rift } = this.props;
        console.log(rift);
        return (
            <div>
                <iframe src={rift[0]} title="Rift 1" />
                <iframe src={rift[1]} title="Rift 2" />
            </div>
        )
    }
}

export default connect(state =>  {
    return {
        rift: state.rift
    }
}
)(Rift);
