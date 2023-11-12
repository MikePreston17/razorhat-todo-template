namespace RazorHAT_Template;

public interface ITPOTPaperRepository
{
	void InsertTPOTPaper(TPOTMarkdownPaper tpotMarkdownPaper);
	IList<TPOTMarkdownPaper> GetTPOTPaperByType(string type);
	void UpdateTPOTPaperList(IList<TPOTMarkdownPaper> TPOTPaperList);
}
