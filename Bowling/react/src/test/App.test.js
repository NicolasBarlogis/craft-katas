import React from "react";
import App from "../App";
import Enzyme, { shallow, mount } from "enzyme";
import Adapter from "@wojtekmaj/enzyme-adapter-react-17";
import ScoreBoard from "../ScoreBoard";
import RollButtons from "../RollButtons";

beforeAll(() => {
  Enzyme.configure({ adapter: new Adapter() });
});

describe("The App renders correctly", () => {
  it("renders without crashing", () => {
    shallow(<App />);
  });

  it("renders a ScoreBoard component", () => {
    const wrapper = setup();
    expect(wrapper.find(ScoreBoard)).toBeDefined();
  });
});

it("A game should have 10 rounds", () => {
  //Arrange
  const game = new Game();

  //Act

  //Assert
  expect(game.rounds).to.have.lengthOf(10);
});

function setup() {
  return shallow(<App />);
}
