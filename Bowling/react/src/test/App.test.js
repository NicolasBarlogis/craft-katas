import React from "react";
import App from "../App";
import Enzyme, { shallow, mount } from "enzyme";
import Adapter from "@wojtekmaj/enzyme-adapter-react-17";
import ScoreBoard from "../ScoreBoard";
import Game from "../domain/Game";
import { expect as expectChai } from 'chai';

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
  expectChai(game.rounds).to.have.lengthOf(10);
});

it("A perfect game score should be 300 points", () => {
  //Arrange
  const game = new Game();

  //Act

  //Assert
  expectChai(game.totalScore).to.be(300);
});

function setup() {
  return shallow(<App />);
}
