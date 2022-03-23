import React from 'react';
import App from '../App';
import Enzyme, {shallow, mount} from 'enzyme';
import Adapter from '@wojtekmaj/enzyme-adapter-react-17';
import ScoreBoard from '../ScoreBoard';
import RollButtons from '../RollButtons';

beforeAll(() => {
  Enzyme.configure({ adapter: new Adapter() });
});


describe('The App renders correctly', () => {
  it('renders without crashing', () => {
    shallow(<App />);
  });

  it('renders a ScoreBoard component', () => {
    const wrapper = setup();
    expect(wrapper.find(ScoreBoard)).toBeDefined();
  });
});

function setup() {
  return shallow(<App />);
}