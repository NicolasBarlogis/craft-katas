import React from 'react';
import PropTypes from 'prop-types';

const RollButton = ({number}) => (
  <button
    type="button">
    {number}
  </button>
);

RollButton.propTypes = {
  number: PropTypes.number.isRequired
};

export default RollButton;