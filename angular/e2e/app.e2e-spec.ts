import { ProCarlosV1TemplatePage } from './app.po';

describe('ProCarlosV1 App', function() {
  let page: ProCarlosV1TemplatePage;

  beforeEach(() => {
    page = new ProCarlosV1TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
