using AdapterEx1;
using AdapterEx1.ConcreteClases;

CommunicationSystem communication = new CommunicationSystem();
EnglishSpeaker gringo = new EnglishSpeaker();
SpanishSpeaker peruano = new SpanishSpeaker();
Translator bilingue = new Translator(peruano);

communication.StartConversation(gringo, "How are you?", "Im fine");
communication.StartConversation(bilingue, "Como estas?", "Bien gracias");
