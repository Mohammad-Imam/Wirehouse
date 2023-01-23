import { WarehouseTemplatePage } from './app.po';

describe('Warehouse App', function() {
  let page: WarehouseTemplatePage;

  beforeEach(() => {
    page = new WarehouseTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
