

 class Word {
     constructor(wordID, text, rank, translation, transcription, isForgoten, favourite, examplesEn, examplesRu) {
        this.wordID = wordID;
        this.text = text;
        this.rank = rank;
        this.translation = translation;
        this.transcription = transcription;
        this.isForgoten = isForgoten;
        this.favourite = favourite;
         this.examplesEn = examples;
         this.examplesRu = examples;
    }

    parse(wordObject) {
        this.wordID = wordObject['wordID'];
        this.text = wordObject['text'];
        this.rank = wordObject['rank'];
        this.translation = wordObject['translation'];
        this.transcription = wordObject['transcription'];
        this.isForgoten = wordObject['isForgoten'];
        this.favourite = wordObject['favourite'];
        this.examplesEn = wordObject['examplesEn'];
        this.examplesRu = wordObject['examplesRu'];
    }

    static parse(wordObject) {
        var temp = new Word();
        temp.wordID = wordObject['wordID'];
        temp.text = wordObject['text'];
        temp.rank = wordObject['rank'];
        temp.transcription = wordObject['transcription'];
        temp.translation = wordObject['translation'];
        temp.isForgoten = wordObject['isForgoten'];
        temp.favourite = wordObject['favourite'];
        temp.examplesEn = wordObject['examplesEn'];
        temp.examplesRu = wordObject['examplesRu'];
        return temp;
    }
}

export {Word}


