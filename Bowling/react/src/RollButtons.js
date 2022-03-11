import React from 'react';
import RollButton from './RollButton';

const RollButtons = () =>  {
  return (<div className="rolls">
    <RollButton number={0} />
    <RollButton number={1} />
    <RollButton number={2} />
    <RollButton number={3} />
    <RollButton number={4} />
    <RollButton number={5} />
    <RollButton number={6} />
    <RollButton number={7} />
    <RollButton number={8} />
    <RollButton number={9} />
    <RollButton number={10} />
  </div>);
};

export default RollButtons;