import {Submarine} from "../src/Submarine";
import {CommandBuilder} from "../src/CommandBuilder";
import {Command} from "../src/Command";
import {readFileSync} from 'fs';

test('1-New Submarine should have a correct starting position', () => {
	// Given - Arrange
	let submarine: Submarine = new Submarine();

	// When - Act

	
	// Then - Assert
	expect(submarine.depth).toBe(0);
	expect(submarine.position).toBe(0);
})

function getCommandsFromCommandsFile(): Command[] {
	const stringCommands: string[] = readFileSync('test/submarineCommands.txt', 'utf-8').split(/\r?\n/);
	return stringCommands.map(command => CommandBuilder.FromText(command));
}